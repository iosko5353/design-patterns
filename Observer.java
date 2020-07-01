package stateAndObserver;

public interface Observer {
    public void update();
    public void setTopic(Observable topic);
}
