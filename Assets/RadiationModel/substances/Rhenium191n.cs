
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium191n : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium191n";
        public override double halfLife { get; } = 5e-05d;
        public override double atomicWeight { get; } = 190.96484d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Rhenium191() } },

        };
    }
}
    
    