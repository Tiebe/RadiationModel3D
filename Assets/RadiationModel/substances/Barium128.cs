using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Barium128 : RadioactiveSubstance
    {
        public override string name { get; } = "Barium128";
        public override double halfLife { get; } = 209952.0d;
        public override double atomicWeight { get; } = 127.90835d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Cesium128()), new(0.00018849999999999997d, new GammaParticle(101720.0, 0.01219)), new(0.0001595d, new GammaParticle(129240.0, 0.00959)), new(0.00010149999999999999d, new GammaParticle(143800.0, 0.00862)), new(0.0001305d, new GammaParticle(159710.0, 0.00776)), new(0.00037699999999999995d, new GammaParticle(187000.0, 0.00663)), new(0.00037699999999999995d, new GammaParticle(187000.0, 0.00663)), new(0.000696d, new GammaParticle(215470.0, 0.00575)), new(0.0010585d, new GammaParticle(229500.0, 0.0054)), new(0.145d, new GammaParticle(273440.0, 0.00453)), new(0.000319d, new GammaParticle(317160.0, 0.00391)), new(0.000957d, new GammaParticle(359100.0, 0.00345)), new(0.0030885d, new GammaParticle(374990.0, 0.00331)), new(0.09210162504399999d, new GammaParticle(4749.0, 0.26107)), new(0.2150914309803486d, new GammaParticle(30625.0, 0.04048)), new(0.39736085531193166d, new GammaParticle(30973.0, 0.04003)), new(0.11609023240170392d, new GammaParticle(35089.0, 0.03533)), new(0.1444162491077197d, new GammaParticle(35414.0, 0.03501)), new(0.02832601670601576d, new GammaParticle(35818.0, 0.03462)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    