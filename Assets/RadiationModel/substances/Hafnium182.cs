
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hafnium182 : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium182";
        public override double halfLife { get; } = 280856872800000.0d;
        public override double atomicWeight { get; } = 181.95056d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Tantalum182() } },

        };
    }
}
    
    