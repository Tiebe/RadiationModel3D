using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium186m : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium186m";
        public override double halfLife { get; } = 27.5d;
        public override double atomicWeight { get; } = 185.97868d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 8679000.0), new Mercury186() } },
            { 6e-05d, new List<RadioactiveSubstance> { new AlphaParticle(7041002.09), new Gold182() } },

        };
    }
}
    
    