using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Phosphorus36 : RadioactiveSubstance
    {
        public override string name { get; } = "Phosphorus36";
        public override double halfLife { get; } = 5.6d;
        public override double atomicWeight { get; } = 35.97826d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Sulfur36() }, { 1.0d, new BetaParticle(-1, 5206570.0) }, { 0.025d, new GammaParticle(184600.0, 0.00672) }, { 0.004d, new GammaParticle(579700.0, 0.00214) }, { 0.017d, new GammaParticle(757500.0, 0.00164) }, { 0.054000000000000006d, new GammaParticle(809400.0, 0.00153) }, { 0.161d, new GammaParticle(828800.0, 0.0015) }, { 0.7040000000000001d, new GammaParticle(901800.0, 0.00137) }, { 0.006d, new GammaParticle(1013400.0, 0.00122) }, { 0.053d, new GammaParticle(1058500.0, 0.00117) }, { 0.045d, new GammaParticle(1255700.0, 0.00099) }, { 0.040999999999999995d, new GammaParticle(1284300.0, 0.00097) }, { 0.006d, new GammaParticle(1441000.0, 0.00086) }, { 0.353d, new GammaParticle(1638200.0, 0.00076) }, { 0.005d, new GammaParticle(1730600.0, 0.00072) }, { 0.135d, new GammaParticle(1960200.0, 0.00063) }, { 0.051d, new GammaParticle(2020600.0, 0.00061) }, { 0.008d, new GammaParticle(2065700.0, 0.0006) }, { 0.016d, new GammaParticle(2250300.0, 0.00055) }, { 0.02d, new GammaParticle(2321600.0, 0.00053) }, { 0.174d, new GammaParticle(2539900.0, 0.00049) }, { 0.027999999999999997d, new GammaParticle(3079100.0, 0.0004) }, { 1.0d, new GammaParticle(3290700.0, 0.00038) }, { 3.85299739071e-08d, new GammaParticle(185.0, 6.70185) }, { 5.588141511825822e-07d, new GammaParticle(2306.0, 0.53766) }, { 1.1059057019247619e-06d, new GammaParticle(2308.0, 0.53719) }, { 1.0321263089265535e-07d, new GammaParticle(2466.0, 0.50277) }, { 1.0321263089265535e-07d, new GammaParticle(2466.0, 0.50277) } } },

        };
    }
}
    