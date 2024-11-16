using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thorium216m : RadioactiveSubstance
    {
        public override string name { get; } = "Thorium216m";
        public override double halfLife { get; } = 0.00014d;
        public override double atomicWeight { get; } = 216.01325d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.972d, new List<RadioactiveSubstance> { new GammaParticle((2041000.0, 0.00061)), new Thorium216() } },
            { 0.027999999999999997d, new List<RadioactiveSubstance> { new AlphaParticle(11136002.09), new Radium212() } },

        };
    }
}
    
    