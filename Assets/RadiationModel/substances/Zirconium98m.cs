using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zirconium98m : RadioactiveSubstance
    {
        public override string name { get; } = "Zirconium98m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 97.91983d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((6602000.0, 0.00019)), new Zirconium98() } },

        };
    }
}
    
    