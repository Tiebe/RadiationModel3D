
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gallium72 : RadioactiveSubstance
    {
        public override string name { get; } = "Gallium72";
        public override double halfLife { get; } = 50490.0d;
        public override double atomicWeight { get; } = 71.92637d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Germanium72() } },

        };
    }
}
    
    