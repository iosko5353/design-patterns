package stateAndObserver;

public class StartState implements State {
    public void doAction(Context context) {
        System.out.println("Конят започва да се храни и играчът получава съобщение");
        context.setState(this);
    }

}
