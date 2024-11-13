
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bohrium271 : RadioactiveSubstance
    {
        public override string name { get; } = "Bohrium271";
        public override double halfLife { get; } = 2.9d;
        public override double atomicWeight { get; } = 271.13512d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Dubnium267() } },

        };
    }
}
    
    