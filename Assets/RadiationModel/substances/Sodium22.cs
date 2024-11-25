using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Sodium22 : RadioactiveSubstance
    {
        public override string name { get; } = "Sodium22";
        public override double halfLife { get; } = 82104810.00069d;
        public override double atomicWeight { get; } = 21.99444d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Fluorine22() }, { 1.0d, new BetaParticle(1, -3987195.0) }, { 0.9994d, new GammaParticle(1274537.0, 0.00097) }, { 1.7991d, new GammaParticle(511000.0, 0.00243) }, { 0.0009372404753452223d, new GammaParticle(848.0, 1.46208) }, { 0.0004712445110035778d, new GammaParticle(848.0, 1.46208) } } },

        };
    }
}
    