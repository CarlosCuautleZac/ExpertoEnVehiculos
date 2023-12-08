using chen0040.ExpertSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using chen0040.ExpertSystem;

namespace ExpertoEnVehiculos
{
    public class VehhiculosRIE
    {


        public RuleInferenceEngine getInferenceEngine()
        {
            RuleInferenceEngine rie = new RuleInferenceEngine();

            // Revolver
            Rule ruleRevolver = new Rule("Revolver");
            ruleRevolver.AddAntecedent(new IsClause("rango", "Corto a Mediano"));
            ruleRevolver.AddAntecedent(new IsClause("mecanismo", "Rotativo (cilindro giratorio)"));
            ruleRevolver.AddAntecedent(new IsClause("tamaño", "Variable"));
            ruleRevolver.AddAntecedent(new IsClause("propósito", "Autodefensa personal"));
            ruleRevolver.setConsequent(new IsClause("Arma de fuego", "Revolver"));
            rie.AddRule(ruleRevolver);

            // Pistolas
            Rule rulePistolas = new Rule("Pistolas");
            rulePistolas.AddAntecedent(new IsClause("rango", "Corto a Mediano"));
            rulePistolas.AddAntecedent(new IsClause("mecanismo", "Semiautomático"));
            rulePistolas.AddAntecedent(new IsClause("tamaño", "Variable"));
            rulePistolas.AddAntecedent(new IsClause("propósito", "Autodefensa personal"));
            rulePistolas.setConsequent(new IsClause("Arma de fuego", "Pistolas"));
            rie.AddRule(rulePistolas);

            // Carabinas
            Rule ruleCarabinas = new Rule("Carabinas");
            ruleCarabinas.AddAntecedent(new IsClause("rango", "Mediano a Largo"));
            ruleCarabinas.AddAntecedent(new IsClause("mecanismo", "Semiautomático o Automático"));
            ruleCarabinas.AddAntecedent(new IsClause("tamaño", "Variable"));
            ruleCarabinas.AddAntecedent(new IsClause("propósito", "Versatilidad táctica"));
            ruleCarabinas.setConsequent(new IsClause("Arma de fuego", "Carabinas"));
            rie.AddRule(ruleCarabinas);

            // Rifles
            Rule ruleRifles = new Rule("Rifles");
            ruleRifles.AddAntecedent(new IsClause("rango", "Mediano a Largo"));
            ruleRifles.AddAntecedent(new IsClause("mecanismo", "Variable"));
            ruleRifles.AddAntecedent(new IsClause("tamaño", "Largo"));
            ruleRifles.AddAntecedent(new IsClause("propósito", "Precisión a larga distancia"));
            ruleRifles.setConsequent(new IsClause("Arma de fuego", "Rifles"));
            rie.AddRule(ruleRifles);

            // Fusiles
            Rule ruleFusiles = new Rule("Fusiles");
            ruleFusiles.AddAntecedent(new IsClause("rango", "Mediano a Largo"));
            ruleFusiles.AddAntecedent(new IsClause("mecanismo", "Variable"));
            ruleFusiles.AddAntecedent(new IsClause("tamaño", "Largo"));
            ruleFusiles.AddAntecedent(new IsClause("propósito", "Combate táctico"));
            ruleFusiles.setConsequent(new IsClause("Arma de fuego", "Fusiles"));
            rie.AddRule(ruleFusiles);

            // Subametralladoras
            Rule ruleSubametralladoras = new Rule("Subametralladoras");
            ruleSubametralladoras.AddAntecedent(new IsClause("rango", "Corto a Mediano"));
            ruleSubametralladoras.AddAntecedent(new IsClause("mecanismo", "Automático"));
            ruleSubametralladoras.AddAntecedent(new IsClause("tamaño", "Variable"));
            ruleSubametralladoras.AddAntecedent(new IsClause("propósito", "Combate cercano"));
            ruleSubametralladoras.setConsequent(new IsClause("Arma de fuego", "Subametralladoras"));
            rie.AddRule(ruleSubametralladoras);

            // Ametralladoras
            Rule ruleAmetralladoras = new Rule("Ametralladoras");
            ruleAmetralladoras.AddAntecedent(new IsClause("rango", "Mediano a Largo"));
            ruleAmetralladoras.AddAntecedent(new IsClause("mecanismo", "Automático"));
            ruleAmetralladoras.AddAntecedent(new IsClause("tamaño", "Variable"));
            ruleAmetralladoras.AddAntecedent(new IsClause("propósito", "Sostenimiento de fuego"));
            ruleAmetralladoras.setConsequent(new IsClause("Arma de fuego", "Ametralladoras"));
            rie.AddRule(ruleAmetralladoras);

            // Escopetas
            Rule ruleEscopetas = new Rule("Escopetas");
            ruleEscopetas.AddAntecedent(new IsClause("rango", "Corto a Mediano"));
            ruleEscopetas.AddAntecedent(new IsClause("mecanismo", "Variable"));
            ruleEscopetas.AddAntecedent(new IsClause("tamaño", "Variable"));
            ruleEscopetas.AddAntecedent(new IsClause("propósito", "Versatilidad (caza, autodefensa)"));
            ruleEscopetas.setConsequent(new IsClause("Arma de fuego", "Escopetas"));
            rie.AddRule(ruleEscopetas);

            // Francotirador
            Rule ruleFrancotirador = new Rule("Francotirador");
            ruleFrancotirador.AddAntecedent(new IsClause("rango", "Largo"));
            ruleFrancotirador.AddAntecedent(new IsClause("mecanismo", "Variable"));
            ruleFrancotirador.AddAntecedent(new IsClause("tamaño", "Largo"));
            ruleFrancotirador.AddAntecedent(new IsClause("propósito", "Precisión a larga distancia"));
            ruleFrancotirador.setConsequent(new IsClause("Arma de fuego", "Francotirador"));
            rie.AddRule(ruleFrancotirador);

            return rie;
        }

        public void ForwardChaining()
        {
            RuleInferenceEngine rie = getInferenceEngine();
            rie.AddFact(new IsClause("rango", "Largo"));
            rie.AddFact(new IsClause("mecanismo", "Variable"));
            rie.AddFact(new IsClause("tamaño", "Largo"));
            rie.AddFact(new IsClause("propósito", "Precisión a larga distancia"));

            Console.WriteLine("before inference");
            Console.WriteLine("{0}", rie.Facts);
            Console.WriteLine("");

            rie.Infer(); // Forward chain

            Console.WriteLine("before inference");
            Console.WriteLine("{0}", rie.Facts);
            Console.WriteLine("");
        }

    }
}
