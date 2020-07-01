package stateAndObserver;

public class Player implements Observer{

    private String name;
    private Observable topic;

    public Player(String name) {
        this.setName(name);
    }

    @Override
    public void update() {

        String topicName = topic.getUpdate();
        System.out.println(this.getName() + " наблюдава " + topicName);

    }
    @Override
    public void setTopic(Observable topic) {
        this.topic = topic;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }
}
