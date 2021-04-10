using System.Collections.Generic;

namespace Projet_Xamarin_CEMEMA.Model
{
    public class ListEvent
    {
        public List<EvenementModel> evenements = new List<EvenementModel>();
        private EvenementModel evenementModel;

        public ListEvent()
        {
        }

        public void AddEvent(EvenementModel e)
        {
            evenements.Add(e);
        }

        public void RemoveEvent(string e)
        {
            foreach(EvenementModel em in evenements)
            {
                if(em.Name == e)
                {
                    evenements.Remove(em);
                }
            }
        }

        public EvenementModel FindEvent(string e)
        {

            foreach(EvenementModel em in evenements)
            {
                if (em.Name == e)
                {
                    evenementModel = em;
                }
            }

            return evenementModel;
        }
    }
}
