using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tellurium104 : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium104";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 103.94672d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(6115047.4), new Tin100() } },

        };
    }
}
    
    