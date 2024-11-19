using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium174m : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium174m";
        public override double halfLife { get; } = 12268800.0d;
        public override double atomicWeight { get; } = 173.94053d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9937999999999999d, new List<RadioactiveSubstance> { new GammaParticle((170800.00001, 0.00726)), new Lutetium174() } },
            { 0.0062d, new List<RadioactiveSubstance> { new Ytterbium174() } },

        };
    }
}
    
    