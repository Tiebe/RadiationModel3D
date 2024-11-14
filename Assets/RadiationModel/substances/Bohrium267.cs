using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bohrium267 : RadioactiveSubstance
    {
        public override string name { get; } = "Bohrium267";
        public override double halfLife { get; } = 22.0d;
        public override double atomicWeight { get; } = 267.1275d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(10255047.4), new Dubnium263() } },

        };
    }
}
    
    