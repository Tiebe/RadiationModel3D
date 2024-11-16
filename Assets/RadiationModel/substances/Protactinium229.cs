using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Protactinium229 : RadioactiveSubstance
    {
        public override string name { get; } = "Protactinium229";
        public override double halfLife { get; } = 133920.0d;
        public override double atomicWeight { get; } = 229.0321d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9951000000000001d, new List<RadioactiveSubstance> { new Thorium229() } },
            { 0.0049d, new List<RadioactiveSubstance> { new AlphaParticle(6857002.09), new Actinium225() } },

        };
    }
}
    
    