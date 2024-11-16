using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Carbon14i : RadioactiveSubstance
    {
        public override string name { get; } = "Carbon14i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 14.02697d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((22100107.0, 6e-05)), new Carbon14() } },

        };
    }
}
    
    