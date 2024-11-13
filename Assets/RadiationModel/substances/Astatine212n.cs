
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Astatine212n : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine212n";
        public override double halfLife { get; } = 0.00015d;
        public override double atomicWeight { get; } = 211.99586d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Astatine212() } },

        };
    }
}
    
    