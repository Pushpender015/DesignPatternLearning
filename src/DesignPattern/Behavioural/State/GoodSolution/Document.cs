using DesignPatternLearning.src.DesignPattern.Behavioural;

namespace DesignPatternLearning.src.DesignPattern.Behavioural.State.GoodSolution
{
    public class Document
    {
        public State State { get; set; }
        public UserRoles CurrentUserRole { get; set; }

        public Document(UserRoles CurrentUserRole)
        {
            State = new DraftState(this);
            CurrentUserRole = CurrentUserRole;
        }

        public void Publish()
        {
            State.publish();
        }
    }
}
