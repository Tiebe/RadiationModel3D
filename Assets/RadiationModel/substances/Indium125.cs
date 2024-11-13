
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium125 : RadioactiveSubstance
    {
        public override string name { get; } = "Indium125";
        public override double halfLife { get; } = 2.36d;
        public override double atomicWeight { get; } = 124.91367d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Tin125() } },

        };
    }
}
    
    