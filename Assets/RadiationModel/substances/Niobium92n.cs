
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Niobium92n : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium92n";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 91.90743d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Niobium92() } },

        };
    }
}
    
    