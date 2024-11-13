
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iodine142 : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine142";
        public override double halfLife { get; } = 0.235d;
        public override double atomicWeight { get; } = 141.94117d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Xenon142() } },

        };
    }
}
    
    