using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium169m : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium169m";
        public override double halfLife { get; } = 160.0d;
        public override double atomicWeight { get; } = 168.93768d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((29000.0, 0.04275)), new Lutetium169() } },

        };
    }
}
    
    