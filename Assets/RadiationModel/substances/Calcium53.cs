
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Calcium53 : RadioactiveSubstance
    {
        public override string name { get; } = "Calcium53";
        public override double halfLife { get; } = 0.461d;
        public override double atomicWeight { get; } = 52.96845d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Scandium53() } },

        };
    }
}
    
    