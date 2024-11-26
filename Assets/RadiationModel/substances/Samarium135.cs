using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Samarium135 : RadioactiveSubstance
    {
        public override string name { get; } = "Samarium135";
        public override double halfLife { get; } = 10.3d;
        public override double atomicWeight { get; } = 134.93252d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Neodymium135() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) } } },
            { 0.0002d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Neodymium134() }, { 1.0d, new ProtonParticle() } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    