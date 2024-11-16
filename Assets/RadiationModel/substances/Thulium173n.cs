using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thulium173n : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium173n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 172.94165d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00065), new Thulium173() } },

        };
    }
}
    
    