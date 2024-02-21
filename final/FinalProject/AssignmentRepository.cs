public class AssignmentRepository
{
    private List<Assignment> assignments = new List<Assignment>();

    public void AddAssignment(Assignment assignment)
    {
        assignments.Add(assignment);
    }
    public List<Assignment> GetAllAssignments()
    {
        return assignments;
    }
    
   
}