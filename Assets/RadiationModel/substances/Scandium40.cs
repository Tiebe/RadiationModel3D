
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Scandium40 : RadioactiveSubstance
    {
        public override string name { get; } = "Scandium40";
        public override double halfLife { get; } = 0.1823d;
        public override double atomicWeight { get; } = 39.97797d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Calcium40() } },

        };
    }
}
    
    