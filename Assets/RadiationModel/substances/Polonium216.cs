using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Polonium216 : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium216";
        public override double halfLife { get; } = 0.145d;
        public override double atomicWeight { get; } = 216.00191d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lead212() }, { 1.0d, new AlphaParticle(7928202.09) }, { 1.9e-05d, new GammaParticle(804900.0, 0.00154) }, { 5.913381989e-08d, new GammaParticle(12522.0, 0.09901) }, { 4.263952924134991e-08d, new GammaParticle(72805.0, 0.01703) }, { 7.166307435520993e-08d, new GammaParticle(74970.0, 0.01654) }, { 2.449341505640568e-08d, new GammaParticle(84986.0, 0.01459) }, { 3.189042640344019e-08d, new GammaParticle(86022.0, 0.01441) }, { 7.397011347034515e-09d, new GammaParticle(87301.0, 0.0142) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    