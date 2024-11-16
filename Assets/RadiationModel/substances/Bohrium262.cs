using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bohrium262 : RadioactiveSubstance
    {
        public override string name { get; } = "Bohrium262";
        public override double halfLife { get; } = 0.084d;
        public override double atomicWeight { get; } = 262.12265d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(11337002.09), new Dubnium258() } },
            { 0.2d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    