
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Californium250 : RadioactiveSubstance
    {
        public override string name { get; } = "Californium250";
        public override double halfLife { get; } = 412764932.16d;
        public override double atomicWeight { get; } = 250.0764d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.9992300000000001d, new List<RadioactiveSubstance> { new AlphaParticle(), new Curium246() } },

            { 0.00077d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    