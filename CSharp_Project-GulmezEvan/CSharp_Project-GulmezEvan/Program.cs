// See https://aka.ms/new-console-template for more information
using System.Collections;

// les attributs et les modificateurs de classe (niveau d'accès) sont placés a 
// avant le mot cle classe
class MaClasse
{
    // les membres : méthodes, propriétés

    public int MyProperty { get; set; }
}
// Public
// Autorise l'accès a tous les types et a tout le projet

// Private
// Autorise l'accès uniquement pour les autres membres du type

// Internal
// Uniquement au sein de l'espace de nom du type 

// Protected
// Accès pour les autres membres du type et pour tous les types héritant
// de celui-ci même en dehors de l'espace de nom l'"assembly"