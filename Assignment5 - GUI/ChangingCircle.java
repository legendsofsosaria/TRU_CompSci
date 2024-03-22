import javafx.application.Application; 
import javafx.scene.Scene; 
import javafx.scene.control.Button; 
import javafx.scene.layout.*; 
import javafx.event.ActionEvent; 
import javafx.scene.shape.Circle; 
import javafx.scene.control.*; 
import javafx.stage.Stage; 
import javafx.scene.Group;
import javafx.geometry.Orientation;
import javafx.geometry.Insets;
import javafx.scene.control.ToggleGroup;
import javafx.scene.control.Slider;
import javafx.geometry.Pos;
import javafx.scene.text.Font; 
import javafx.scene.text.FontPosture; 
import javafx.scene.text.FontWeight; 
import javafx.scene.text.Text;
import javafx.scene.paint.Color;

/**
 * Elizabeth House
 * 03/21/2024
 */
public class ChangingCircle extends Application
{
    private final double initialSize = 35.0; /* Store initial size of circle */
    
    public void start(Stage stage)
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
        Circle circle = new Circle(initialSize);
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

        /* Event Handling */
        r1.setOnAction(e -> circle.setFill(javafx.scene.paint.Color.ORANGE));
        r2.setOnAction(e -> circle.setFill(javafx.scene.paint.Color.YELLOW));
        r3.setOnAction(e -> circle.setFill(javafx.scene.paint.Color.BLUE));
        
        slider.valueProperty().addListener((obs, oldValue, newValue) -> 
        {
            double radius = initialSize + (newValue.doubleValue() / 100 * (initialSize * 2 - initialSize));
            circle.setRadius(radius);
        });

        /* Scene */
        VBox mainLayout = new VBox();
        mainLayout.setStyle("-fx-background-color: beige;"); 
        mainLayout.getChildren().addAll(hbox, sliderLayout, bottomLayout); 
        Scene scene = new Scene(mainLayout, 500, 400);
        stage.setScene(scene);
        stage.show();
    }

    public static void main(String[] args) 
    {
        launch(args);
    }
}
