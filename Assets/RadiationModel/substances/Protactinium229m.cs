using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Protactinium229m : RadioactiveSubstance
    {
        public override string name { get; } = "Protactinium229m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 229.03211d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.10332), new Protactinium229() } },

        };
    }
}
    
    