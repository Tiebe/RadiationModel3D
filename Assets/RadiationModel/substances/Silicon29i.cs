
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silicon29i : RadioactiveSubstance
    {
        public override string name { get; } = "Silicon29i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 28.98539d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Silicon29() } },

        };
    }
}
    
    