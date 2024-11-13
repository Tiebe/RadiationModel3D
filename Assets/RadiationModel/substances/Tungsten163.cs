
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tungsten163 : RadioactiveSubstance
    {
        public override string name { get; } = "Tungsten163";
        public override double halfLife { get; } = 2.63d;
        public override double atomicWeight { get; } = 162.96252d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.14d, new List<RadioactiveSubstance> { new AlphaParticle(), new Hafnium159() } },

        };
    }
}
    
    