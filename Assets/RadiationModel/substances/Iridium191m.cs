using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium191m : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium191m";
        public override double halfLife { get; } = 4.899d;
        public override double atomicWeight { get; } = 190.96078d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Iridium191()), new(5.921e-05d, new GammaParticle(41890.0, 0.0296)), new(2.5e-05d, new GammaParticle(47050.0, 0.02635)), new(0.00031d, new GammaParticle(82427.0, 0.01504)), new(0.2666d, new GammaParticle(129427.0, 0.00958)), new(0.4195947528751d, new GammaParticle(10728.0, 0.11557)), new(0.15924672562275158d, new GammaParticle(63287.0, 0.01959)), new(0.2732911028363679d, new GammaParticle(64896.0, 0.01911)), new(0.09169936815345324d, new GammaParticle(73637.0, 0.01684)), new(0.11765028934088051d, new GammaParticle(74510.0, 0.01664)), new(0.025950921187427266d, new GammaParticle(75576.0, 0.01641)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    