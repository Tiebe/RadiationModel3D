
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum174 : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum174";
        public override double halfLife { get; } = 4104.0d;
        public override double atomicWeight { get; } = 173.94445d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Hafnium174() } },

        };
    }
}
    
    