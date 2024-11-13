
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum173 : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum173";
        public override double halfLife { get; } = 11304.0d;
        public override double atomicWeight { get; } = 172.94375d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Hafnium173() } },

        };
    }
}
    
    