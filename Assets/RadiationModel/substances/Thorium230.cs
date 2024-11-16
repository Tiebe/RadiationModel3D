using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thorium230 : RadioactiveSubstance
    {
        public override string name { get; } = "Thorium230";
        public override double halfLife { get; } = 2379394180800.0d;
        public override double atomicWeight { get; } = 230.03313d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(5791902.09), new Radium226() } },
            { 4e-14d, new List<RadioactiveSubstance> {  } },
            { 5.8e-13d, new List<RadioactiveSubstance> { new Neon24(), new Mercury206() } },

        };
    }
}
    
    