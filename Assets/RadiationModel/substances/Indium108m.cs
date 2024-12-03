using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Indium108m : RadioactiveSubstance
    {
        public override string name { get; } = "Indium108m";
        public override double halfLife { get; } = 2376.0d;
        public override double atomicWeight { get; } = 107.90973d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Silver108()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.0016044d, new GammaParticle(156200.0, 0.00794)), new(0.0078692d, new GammaParticle(171400.0, 0.00723)), new(0.0100848d, new GammaParticle(311600.0, 0.00398)), new(0.0035908d, new GammaParticle(391300.0, 0.00317)), new(0.0080984d, new GammaParticle(536100.0, 0.00231)), new(0.764d, new GammaParticle(632900.0, 0.00196)), new(0.0032088d, new GammaParticle(770900.0, 0.00161)), new(0.024447999999999998d, new GammaParticle(875400.0, 0.00142)), new(0.0028268d, new GammaParticle(884100.0, 0.0014)), new(0.00191d, new GammaParticle(936000.0, 0.00132)), new(0.043548d, new GammaParticle(968500.0, 0.00128)), new(0.0015279999999999998d, new GammaParticle(1017700.0, 0.00122)), new(0.01528d, new GammaParticle(1087500.0, 0.00114)), new(0.004966d, new GammaParticle(1280100.0, 0.00097)), new(0.0071816d, new GammaParticle(1293700.0, 0.00096)), new(0.0014516000000000002d, new GammaParticle(1408500.0, 0.00088)), new(0.0024448d, new GammaParticle(1445600.0, 0.00086)), new(0.0058828000000000005d, new GammaParticle(1475000.0, 0.00084)), new(0.0090916d, new GammaParticle(1513100.0, 0.00082)), new(0.07334399999999999d, new GammaParticle(1529400.0, 0.00081)), new(0.0097792d, new GammaParticle(1569300.0, 0.00079)), new(0.040492d, new GammaParticle(1601200.0, 0.00077)), new(0.0382d, new GammaParticle(1732100.0, 0.00072)), new(0.03056d, new GammaParticle(1851900.0, 0.00067)), new(0.005348d, new GammaParticle(1864000.0, 0.00067)), new(0.12376799999999999d, new GammaParticle(1986300.0, 0.00062)), new(0.03056d, new GammaParticle(2048300.0, 0.00061)), new(0.0025212d, new GammaParticle(2112400.0, 0.00059)), new(0.005348d, new GammaParticle(2211100.0, 0.00056)), new(0.013752d, new GammaParticle(2224200.0, 0.00056)), new(0.0062648d, new GammaParticle(2278300.0, 0.00054)), new(0.0030559999999999997d, new GammaParticle(2316900.0, 0.00054)), new(0.005348d, new GammaParticle(2365100.0, 0.00052)), new(0.014516d, new GammaParticle(2413200.0, 0.00051)), new(0.00764d, new GammaParticle(2681300.0, 0.00046)), new(0.0069524d, new GammaParticle(2816000.0, 0.00044)), new(0.024447999999999998d, new GammaParticle(3046800.0, 0.00041)), new(0.016044d, new GammaParticle(3178400.0, 0.00039)), new(0.09168d, new GammaParticle(3452200.0, 0.00036)), new(0.010696d, new GammaParticle(3689400.0, 0.00034)), new(0.04202d, new GammaParticle(3811800.0, 0.00033)), new(0.023683999999999997d, new GammaParticle(3825500.0, 0.00032)), new(0.006111999999999999d, new GammaParticle(4052000.0, 0.00031)), new(0.00764d, new GammaParticle(4342800.0, 0.00029)), new(1.0075100000000001d, new GammaParticle(511000.0, 0.00243)), new(0.02603374880600077d, new GammaParticle(3388.0, 0.36595)), new(0.09167341782511373d, new GammaParticle(22983.0, 0.05395)), new(0.1724156814465182d, new GammaParticle(23173.0, 0.0535)), new(0.048058853852223374d, new GammaParticle(26184.0, 0.04735)), new(0.056805565253328034d, new GammaParticle(26381.0, 0.047)), new(0.008746711401104654d, new GammaParticle(26641.0, 0.04654)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    