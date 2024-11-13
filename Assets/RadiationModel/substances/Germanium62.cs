
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Germanium62 : RadioactiveSubstance
    {
        public override string name { get; } = "Germanium62";
        public override double halfLife { get; } = 0.0825d;
        public override double atomicWeight { get; } = 61.95476d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Gallium62() } },

        };
    }
}
    
    