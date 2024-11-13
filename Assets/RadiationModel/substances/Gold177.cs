
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold177 : RadioactiveSubstance
    {
        public override string name { get; } = "Gold177";
        public override double halfLife { get; } = 1.501d;
        public override double atomicWeight { get; } = 176.97687d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.4d, new List<RadioactiveSubstance> { new AlphaParticle(), new Iridium173() } },

            { 0.6d, new List<RadioactiveSubstance> { new BetaParticle(), new Platinum177() } },

        };
    }
}
    
    