package stateAndObserver;

public class ObserverAndStatePatternMain {

    public static void main(String[] args) {

        Context context = new Context();

        StartState startState = new StartState();
        startState.doAction(context);

        System.out.println(context.getState().toString());

        Subject topic = new Subject();
        Subject topic1 = new Subject();
        Subject topic2 = new Subject();
        Observer obs1 = new Player("Player 1");
        Observer obs2 = new Player("Player 1");
        Observer obs3 = new Player("Player 1");

        topic.subscribe(obs1);
        topic1.subscribe(obs2);
        topic2.subscribe(obs3);

        topic.setName("конят как се храни");
        topic1.setName("конят как спи");
        topic2.setName("конят в нормлано състояние");
        HorseState horseState = new HorseState();
        horseState.doAction(context);

        System.out.println(context.getState().toString());

        StopState stopState = new StopState();
        stopState.doAction(context);

        System.out.println(context.getState().toString());
    }
}
