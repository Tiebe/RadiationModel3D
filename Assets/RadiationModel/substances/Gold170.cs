using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold170 : RadioactiveSubstance
    {
        public override string name { get; } = "Gold170";
        public override double halfLife { get; } = 0.00029d;
        public override double atomicWeight { get; } = 169.99603d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.89d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Platinum169() }, { 1.0d, new ProtonParticle() } } },
            { 0.11d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iridium166() }, { 1.0d, new AlphaParticle(8207002.09) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    