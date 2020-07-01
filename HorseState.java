package stateAndObserver;

public class HorseState implements State {
    public void doAction(Context context) {
        System.out.println("Конят се храни и играчът го наблюдава");
        context.setState(this);
    }
}
