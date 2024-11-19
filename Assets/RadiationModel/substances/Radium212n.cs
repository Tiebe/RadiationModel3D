using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radium212n : RadioactiveSubstance
    {
        public override string name { get; } = "Radium212n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 212.00259d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00047, 2613000.0), new Radium212() } },

        };
    }
}
    
    