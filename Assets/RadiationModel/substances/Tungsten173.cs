
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tungsten173 : RadioactiveSubstance
    {
        public override string name { get; } = "Tungsten173";
        public override double halfLife { get; } = 456.0d;
        public override double atomicWeight { get; } = 172.94769d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Tantalum173() } },

        };
    }
}
    
    