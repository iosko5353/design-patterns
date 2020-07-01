package stateAndObserver;

public class StopState implements State {
    public void doAction(Context context) {
        System.out.println("конят е в нормално състояние и играча не получава съобщение");
        context.setState(this);
    }
}