﻿using System.Collections.Generic;

namespace Projet_Xamarin_CEMEMA.Model
{
    public static class ListEvent
    {
        public static List<EvenementModel> evenements = new List<EvenementModel>();
        private static EvenementModel evenementModel;

        public static void AddEvent(EvenementModel e)
        {
            evenements.Add(e);
        }

        public static void RemoveEvent(EvenementModel e)
        {
            evenements.Remove(e);
        }

        public static EvenementModel FindEvent(string e)
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
