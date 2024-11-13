
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Promethium128 : RadioactiveSubstance
    {
        public override string name { get; } = "Promethium128";
        public override double halfLife { get; } = 1.0d;
        public override double atomicWeight { get; } = 127.94823d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Neodymium128() } },

            { 0.0d, new List<RadioactiveSubstance> { new ProtonParticle(), new Neodymium127() } },

        };
    }
}
    
    