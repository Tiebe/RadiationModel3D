using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Platinum171m : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum171m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 170.98169d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Platinum171() }, { 0.09861d, new GammaParticle(89500.0, 0.01385) }, { 0.519d, new GammaParticle(323100.0, 0.00384) }, { 0.3700273903116d, new GammaParticle(11070.0, 0.112) }, { 0.30965165237386044d, new GammaParticle(65122.0, 0.01904) }, { 0.5293190638869409d, new GammaParticle(66832.0, 0.01855) }, { 0.1781018705592525d, new GammaParticle(75821.0, 0.01635) }, { 0.22903900553919876d, new GammaParticle(76725.0, 0.01616) }, { 0.050937134979946216d, new GammaParticle(77832.0, 0.01593) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    