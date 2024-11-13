
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium169m : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium169m";
        public override double halfLife { get; } = 0.00012d;
        public override double atomicWeight { get; } = 168.93837d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Holmium169() } },

        };
    }
}
    
    