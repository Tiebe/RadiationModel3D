using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Bismuth196n : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth196n";
        public override double halfLife { get; } = 240.0d;
        public override double atomicWeight { get; } = 195.98096d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.742d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Thallium196()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.5d, new GammaParticle(59200.0, 0.02094)), new(0.162d, new GammaParticle(138400.0, 0.00896)), new(0.021d, new GammaParticle(164500.0, 0.00754)), new(0.024d, new GammaParticle(283200.0, 0.00438)), new(0.01d, new GammaParticle(288700.0, 0.00429)), new(0.00064d, new GammaParticle(306900.0, 0.00404)), new(0.0048d, new GammaParticle(306900.0, 0.00404)), new(0.244d, new GammaParticle(337500.0, 0.00367)), new(0.69d, new GammaParticle(372200.0, 0.00333)), new(0.0048d, new GammaParticle(400900.0, 0.00309)), new(0.12300000000000001d, new GammaParticle(421700.0, 0.00294)), new(0.045d, new GammaParticle(496300.0, 0.0025)), new(0.67d, new GammaParticle(689300.0, 0.0018)), new(0.053d, new GammaParticle(748800.0, 0.00166)), new(0.0064d, new GammaParticle(749000.0, 0.00166)), new(0.0032d, new GammaParticle(803100.0, 0.00154)), new(0.73d, new GammaParticle(1049400.0, 0.00118)), new(0.0048d, new GammaParticle(1449700.0, 0.00086)), new(0.6452d, new GammaParticle(511000.0, 0.00243)), new(0.313961578257852d, new GammaParticle(12522.0, 0.09901)), new(0.13966725346280032d, new GammaParticle(72805.0, 0.01703)), new(0.23473487976941232d, new GammaParticle(74970.0, 0.01654)), new(0.08022902854975986d, new GammaParticle(84986.0, 0.01459)), new(0.10445819517178734d, new GammaParticle(86022.0, 0.01441)), new(0.024229166622027475d, new GammaParticle(87301.0, 0.0142)) } },
            { 0.258d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Bismuth196()), new(0.0017000000000000001d, new GammaParticle(102000.0, 0.01216)), new(0.0033d, new GammaParticle(158300.0, 0.00783)), new(0.14183057755d, new GammaParticle(12904.0, 0.09608)), new(0.024356791725996748d, new GammaParticle(74815.0, 0.01657)), new(0.040750864524003255d, new GammaParticle(77108.0, 0.01608)), new(0.01395876244257274d, new GammaParticle(87388.0, 0.01419)), new(0.01823014375d, new GammaParticle(88458.0, 0.01402)), new(0.0042713813074272584d, new GammaParticle(89784.0, 0.01381)) } },
            { 3.8e-06d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Thallium192()), new(1.0d, new AlphaParticle(6730002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    