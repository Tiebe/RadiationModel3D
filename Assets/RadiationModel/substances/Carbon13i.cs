
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Carbon13i : RadioactiveSubstance
    {
        public override string name { get; } = "Carbon13i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 13.01957d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.008199999999999999d, new List<RadioactiveSubstance> { new GammaParticle(), new Carbon13() } },

        };
    }
}
    
    