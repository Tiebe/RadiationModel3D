using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Berkelium247 : RadioactiveSubstance
    {
        public override string name { get; } = "Berkelium247";
        public override double halfLife { get; } = 43548557844.93696d;
        public override double atomicWeight { get; } = 247.07031d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Americium243()), new(1.0d, new AlphaParticle(6912002.09)), new(0.013000000000000001d, new GammaParticle(41800.0, 0.02966)), new(0.4d, new GammaParticle(84000.0, 0.01476)), new(0.3d, new GammaParticle(265000.0, 0.00468)), new(0.17755158999999998d, new GammaParticle(18078.0, 0.06858)), new(0.06931494861889878d, new GammaParticle(102031.0, 0.01215)), new(0.10912302994159127d, new GammaParticle(106468.0, 0.01165)), new(0.04044594180704441d, new GammaParticle(120157.0, 0.01032)), new(0.05460202143950995d, new GammaParticle(121688.0, 0.01019)), new(0.014156079632465544d, new GammaParticle(123677.0, 0.01002)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    