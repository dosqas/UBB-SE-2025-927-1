﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Duo.Views.Components.CreateExerciseComponents;
using Microsoft.UI.Xaml.Controls;

namespace Duo.Helpers
{
    public class ExerciseViewFactory : IExerciseViewFactory
    {
        private readonly CreateAssociationExercise associationExerciseView;
        private readonly CreateFillInTheBlankExercise fillInTheBlankExerciseView;
        private readonly CreateMultipleChoiceExercise multipleChoiceExerciseView;
        private readonly CreateFlashcardExercise flashcardExerciseView;

        public ExerciseViewFactory()
        {
            // Instantiate the views
            associationExerciseView = new CreateAssociationExercise();
            fillInTheBlankExerciseView = new CreateFillInTheBlankExercise();
            multipleChoiceExerciseView = new CreateMultipleChoiceExercise();
            flashcardExerciseView = new CreateFlashcardExercise();
        }

        public object CreateExerciseView(string exerciseType)
        {
            switch (exerciseType)
            {
                case "Association":
                    return new CreateAssociationExercise();
                case "Fill in the blank":
                    return new CreateFillInTheBlankExercise();
                case "Multiple Choice":
                    return new CreateMultipleChoiceExercise();
                case "Flashcard":
                    return new CreateFlashcardExercise();
                default:
                    return new TextBlock { Text = "Select an exercise type." };
            }
        }
    }
}
