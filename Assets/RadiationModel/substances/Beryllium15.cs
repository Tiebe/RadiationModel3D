
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Beryllium15 : RadioactiveSubstance
    {
        public override string name { get; } = "Beryllium15";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 15.05349d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new NeutronParticle(), new Beryllium14() } },

        };
    }
}
    
    