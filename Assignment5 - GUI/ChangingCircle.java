import javafx.application.Application; 
import javafx.scene.Scene; 
import javafx.scene.layout.*; 
import javafx.scene.shape.Circle; 
import javafx.scene.control.*; 
import javafx.stage.Stage; 
import javafx.scene.Group;
import javafx.geometry.Orientation;
import javafx.geometry.Insets;
import javafx.scene.control.Slider;
import javafx.geometry.Pos;
import javafx.scene.text.Font; 
import javafx.scene.text.FontWeight; 
import javafx.scene.text.Text;
import javafx.scene.paint.Color;
import javafx.scene.control.Alert.AlertType;
import javafx.scene.input.MouseEvent;
import javafx.scene.media.AudioClip;
import javafx.scene.Node;
import javafx.scene.Parent;

/**
 * Elizabeth House
 * T00738901
 * 03/21/2024
 * GUI that allows you to use a slider to resize a circle
 * Radio buttons will allow you to change between colors (3 colors for the circle)
 * Audio clip will play when you click anywhere on the UI other than the radio buttons or slider
 * Websites used:
 * https://www.javatpoint.com/javafx-tutorial
 * https://www.geeksforgeeks.org/javafx-alert-with-examples/
 * https://jenkov.com/tutorials/javafx/index.html
 */
public class ChangingCircle extends Application
{
    private final double defaultSize = 35; /* Store default size of circle */
    private final AudioClip warningSound = new AudioClip(getClass().getResource("warning.wav").toString());
    private boolean sliderDragging = false; 
    
    public void start(Stage stage) throws Exception
    {
        stage.setTitle("Changing Circle");

        /* Info text */
        Text topText = new Text();
        topText.setText("           Change the circle color using the radio buttons.\n"
        + "Change the scale of the circle between 0-100% using the slider.");
        Text bottomText = new Text();
        bottomText.setText("           Select the radio buttons or slider only.\n"
        + "You'll hear a warning sound if the mouse is clicked elsewhere.");

        /* Text Styling */
        topText.setFont(Font.font("verdana", FontWeight.BOLD, 10));
        bottomText.setFont(Font.font("verdana", FontWeight.NORMAL, 12));
        bottomText.setFill(Color.RED);

        /* Circle */
        Circle circle = new Circle(defaultSize);
        Group group = new Group(circle);
        group.setTranslateX(-180); 
        group.setTranslateY(100);

        /* Radio Buttons */
        RadioButton r1 = new RadioButton("Orange"); 
        RadioButton r2 = new RadioButton("Yellow"); 
        RadioButton r3 = new RadioButton("Blue"); 
        ToggleGroup colorGroup = new ToggleGroup();
        r1.setToggleGroup(colorGroup);
        r2.setToggleGroup(colorGroup);
        r3.setToggleGroup(colorGroup);

        /* Slider */
        Slider slider = new Slider(0, 100, 25);
        slider.setOrientation(Orientation.HORIZONTAL);
        slider.setShowTickMarks(true);
        slider.setShowTickLabels(true);
        slider.setMajorTickUnit(25f);

        /* Layout */
        VBox radioButtonsLayout = new VBox();
        radioButtonsLayout.setSpacing(5);
        radioButtonsLayout.setPadding(new Insets(60, 0, 30, 30)); /* Radio padding */
        radioButtonsLayout.getChildren().addAll(r1, r2, r3);

        FlowPane topLayout = new FlowPane();
        topLayout.setPadding(new Insets(30, 0, 0, 40)); /* Top text label padding */
        topLayout.getChildren().addAll(topText, radioButtonsLayout);

        VBox sliderLayout = new VBox();
        sliderLayout.setPadding(new Insets(40, 30, 0, 30)); /* Slider padding */
        sliderLayout.getChildren().addAll(slider);

        FlowPane bottomLayout = new FlowPane();
        bottomLayout.setPadding(new Insets(20, 0, 0, 40)); /* Bottom text label padding */
        bottomLayout.getChildren().addAll(bottomText);

        HBox hbox = new HBox();
        hbox.setAlignment(Pos.TOP_LEFT);
        hbox.getChildren().addAll(topLayout, group);

        /* Set initial values */
        circle.setFill(javafx.scene.paint.Color.ORANGE);
        r1.setSelected(true);
        slider.setValue(25);

        /* Event Handling to switch circle color */
        r1.setOnAction(e -> circle.setFill(javafx.scene.paint.Color.ORANGE));
        r2.setOnAction(e -> circle.setFill(javafx.scene.paint.Color.YELLOW));
        r3.setOnAction(e -> circle.setFill(javafx.scene.paint.Color.BLUE));
        
        /* Changes the radius on the circle */
        slider.valueProperty().addListener((obs, oldValue, newValue) -> 
        {
            double radius;
            int sliderValue = newValue.intValue();
            
            if (sliderValue >= 25) 
            {
                radius = defaultSize + (sliderValue - 25) / 75.0 * defaultSize;
            } 
            else 
            {
                radius = defaultSize - (25 - sliderValue) / 25.0 * defaultSize;
            }
            circle.setRadius(radius);
        });
        
        
        /* Checking for pressing and releasing mouse and mouse over for slider */
        slider.setOnMousePressed(event -> sliderDragging = true);
        slider.setOnMouseReleased(event -> sliderDragging = false);
        slider.setOnMouseEntered(event -> 
        {
        slider.getProperties().put("mouseOver", true);
        });

        slider.setOnMouseExited(event -> 
        {
        slider.getProperties().put("mouseOver", false);
        });
        

        /* Scene */
        VBox mainLayout = new VBox();
        mainLayout.setStyle("-fx-background-color: beige;"); 
        mainLayout.getChildren().addAll(hbox, sliderLayout, bottomLayout);
        
        Scene scene = new Scene(mainLayout, 500, 400);
        scene.addEventFilter(MouseEvent.MOUSE_CLICKED, event -> 
        {
            Node target = (Node) event.getTarget();
            /* Check if the mouse is over the slider so the alert won't go off there */
            boolean mouseOverSlider = Boolean.TRUE.equals(slider.getProperties().get("mouseOver")); 
    
            /* Check if the mouse is in the radio buttons or sliders, if so no alert */
            if (!(target instanceof RadioButton || target instanceof Slider || sliderDragging ||
              mouseOverSlider || isSubComponent(target, r1) || isSubComponent(target, r2) || isSubComponent(target, r3))) 
            {
                playWarningSound();
                showAlert("Warning", "Please select the radio buttons or slider only.");
            }
        });
        
        stage.setScene(scene);
        stage.show();
    }
    
    /* Plays the warning sound */
    private void playWarningSound() 
    {
        warningSound.play();
    }
    
    /* Warning message */
    private void showAlert(String title, String message) 
    {
        Alert alert = new Alert(AlertType.WARNING);
        alert.setTitle(title);
        alert.setHeaderText(null);
        alert.setContentText(message);
        alert.showAndWait();
    }
    
    /* Checks node components */
    private boolean isSubComponent(Node target, Node component) 
    {
        if (target.equals(component)) 
        {
            return true;
        }


        Parent parent = target.getParent();
        while (parent != null) 
        {
            if (parent.equals(component)) 
            {
                return true;
            }
            parent = parent.getParent();
        }
    
        return false;
    } 

    public static void main(String[] args) 
    {
        launch(args);
    }
}
